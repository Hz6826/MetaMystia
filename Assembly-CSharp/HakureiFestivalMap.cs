using System;
using Cysharp.Threading.Tasks;
using DayScene;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class HakureiFestivalMap : DaySceneMap
{
	// Token: 0x06000087 RID: 135 RVA: 0x000A0B54 File Offset: 0x0009ED54
	// Note: this type is marked as 'beforefieldinit'.
	static HakureiFestivalMap()
	{
		Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HakureiFestivalMap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr);
		HakureiFestivalMap.NativeFieldInfoPtr_musicViewer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, "musicViewer1");
		HakureiFestivalMap.NativeFieldInfoPtr_musicViewer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, "musicViewer2");
		HakureiFestivalMap.NativeFieldInfoPtr_musicViewer3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, "musicViewer3");
		HakureiFestivalMap.NativeFieldInfoPtr_musicViewerSuccess3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, "musicViewerSuccess3");
		HakureiFestivalMap.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, "light");
		HakureiFestivalMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, 100663366);
		HakureiFestivalMap.NativeMethodInfoPtr_SetViewer_Public_GameObject_ViewLabel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, 100663367);
		HakureiFestivalMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, 100663368);
		HakureiFestivalMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr, 100663369);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000A0C38 File Offset: 0x0009EE38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3431, XrefRangeEnd = 3456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override UniTask OnPostEnterSceneAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr;
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new UniTask(pointer);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000A0C7C File Offset: 0x0009EE7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3456, RefRangeEnd = 3457, XrefRangeStart = 3456, XrefRangeEnd = 3456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject SetViewer(HakureiFestivalMap.ViewLabel viewLabel, bool open)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref viewLabel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiFestivalMap.NativeMethodInfoPtr_SetViewer_Public_GameObject_ViewLabel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000A0CD8 File Offset: 0x0009EED8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3457, XrefRangeEnd = 3463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000A0D14 File Offset: 0x0009EF14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3463, XrefRangeEnd = 3467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HakureiFestivalMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HakureiFestivalMap>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiFestivalMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002356 File Offset: 0x00000556
	public HakureiFestivalMap(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600008D RID: 141 RVA: 0x000A0D50 File Offset: 0x0009EF50
	// (set) Token: 0x0600008E RID: 142 RVA: 0x0000235F File Offset: 0x0000055F
	public unsafe GameObject musicViewer1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewer1);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewer1), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600008F RID: 143 RVA: 0x000A0D80 File Offset: 0x0009EF80
	// (set) Token: 0x06000090 RID: 144 RVA: 0x0000237E File Offset: 0x0000057E
	public unsafe GameObject musicViewer2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewer2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewer2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000091 RID: 145 RVA: 0x000A0DB0 File Offset: 0x0009EFB0
	// (set) Token: 0x06000092 RID: 146 RVA: 0x0000239D File Offset: 0x0000059D
	public unsafe GameObject musicViewer3
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewer3);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewer3), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000093 RID: 147 RVA: 0x000A0DE0 File Offset: 0x0009EFE0
	// (set) Token: 0x06000094 RID: 148 RVA: 0x000023BC File Offset: 0x000005BC
	public unsafe GameObject musicViewerSuccess3
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewerSuccess3);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_musicViewerSuccess3), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000095 RID: 149 RVA: 0x000A0E10 File Offset: 0x0009F010
	// (set) Token: 0x06000096 RID: 150 RVA: 0x000023DB File Offset: 0x000005DB
	public unsafe GameObject light
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_light);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalMap.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeFieldInfoPtr_musicViewer1;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeFieldInfoPtr_musicViewer2;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeFieldInfoPtr_musicViewer3;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeFieldInfoPtr_musicViewerSuccess3;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeFieldInfoPtr_light;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeMethodInfoPtr_SetViewer_Public_GameObject_ViewLabel_Boolean_0;

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000465 RID: 1125
	public enum ViewLabel
	{
		// Token: 0x0400519C RID: 20892
		View1,
		// Token: 0x0400519D RID: 20893
		View2,
		// Token: 0x0400519E RID: 20894
		View3,
		// Token: 0x0400519F RID: 20895
		ViewSuccess3,
		// Token: 0x040051A0 RID: 20896
		Light
	}
}
