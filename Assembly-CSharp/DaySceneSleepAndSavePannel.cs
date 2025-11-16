using System;
using DayScene.Input;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class DaySceneSleepAndSavePannel : UISubPanelParamOpen<DaySceneSleepAndSavePrePannel, Action>
{
	// Token: 0x0600012E RID: 302 RVA: 0x000A2D78 File Offset: 0x000A0F78
	// Note: this type is marked as 'beforefieldinit'.
	static DaySceneSleepAndSavePannel()
	{
		Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DaySceneSleepAndSavePannel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr);
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_finishAutoCompleteEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "finishAutoCompleteEvents");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "confirmButton");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_refuseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "refuseButton");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_finalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "finalPosition");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "bezierPt1");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "bezierPt2");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "bezierPt3");
		DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "bezierPt4");
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663432);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663433);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663434);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Confirm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663435);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663436);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663437);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Transform_Single_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663438);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Method_Internal_Static_Single_byref___c__DisplayClass11_1_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663439);
		DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Method_Internal_Static_Vector3_byref___c__DisplayClass11_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, 100663440);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x000A2EFC File Offset: 0x000A10FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17613, XrefRangeEnd = 17631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSleepAndSavePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000A2F38 File Offset: 0x000A1138
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17631, XrefRangeEnd = 17633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelOpen(Action finishAutoCompleteEvents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishAutoCompleteEvents);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSleepAndSavePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000A2F88 File Offset: 0x000A1188
	[CallerCount(2138)]
	[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelClose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSleepAndSavePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x000A2FC4 File Offset: 0x000A11C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17633, XrefRangeEnd = 17682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Confirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Confirm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000A2FF8 File Offset: 0x000A11F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17682, XrefRangeEnd = 17686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x000A3034 File Offset: 0x000A1234
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17686, XrefRangeEnd = 17689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DaySceneSleepAndSavePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x000A3070 File Offset: 0x000A1270
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17689, XrefRangeEnd = 17694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator Method_Internal_Static_IEnumerator_Transform_Single_Vector3_PDM_0(Transform source, float speed, Vector3 point)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Transform_Single_Vector3_PDM_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000A30D0 File Offset: 0x000A12D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17694, XrefRangeEnd = 17697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Method_Internal_Static_Single_byref___c__DisplayClass11_1_PDM_0(ref DaySceneSleepAndSavePannel.__c__DisplayClass11_1 A_0)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Method_Internal_Static_Single_byref___c__DisplayClass11_1_PDM_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000A3114 File Offset: 0x000A1314
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17702, RefRangeEnd = 17703, XrefRangeStart = 17697, XrefRangeEnd = 17702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Method_Internal_Static_Vector3_byref___c__DisplayClass11_1_0(ref DaySceneSleepAndSavePannel.__c__DisplayClass11_1 A_0)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.NativeMethodInfoPtr_Method_Internal_Static_Vector3_byref___c__DisplayClass11_1_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002965 File Offset: 0x00000B65
	public DaySceneSleepAndSavePannel(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000139 RID: 313 RVA: 0x000A3158 File Offset: 0x000A1358
	// (set) Token: 0x0600013A RID: 314 RVA: 0x0000296E File Offset: 0x00000B6E
	public unsafe Action finishAutoCompleteEvents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_finishAutoCompleteEvents);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_finishAutoCompleteEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x0600013B RID: 315 RVA: 0x000A3188 File Offset: 0x000A1388
	// (set) Token: 0x0600013C RID: 316 RVA: 0x0000298D File Offset: 0x00000B8D
	public unsafe UIButtonHold confirmButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_confirmButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600013D RID: 317 RVA: 0x000A31B8 File Offset: 0x000A13B8
	// (set) Token: 0x0600013E RID: 318 RVA: 0x000029AC File Offset: 0x00000BAC
	public unsafe UIButtonSimple refuseButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_refuseButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_refuseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x0600013F RID: 319 RVA: 0x000A31E8 File Offset: 0x000A13E8
	// (set) Token: 0x06000140 RID: 320 RVA: 0x000029CB File Offset: 0x00000BCB
	public unsafe Vector2 finalPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_finalPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_finalPosition)) = value;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000141 RID: 321 RVA: 0x000A3210 File Offset: 0x000A1410
	// (set) Token: 0x06000142 RID: 322 RVA: 0x000029E6 File Offset: 0x00000BE6
	public unsafe Vector2 bezierPt1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt1);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt1)) = value;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000143 RID: 323 RVA: 0x000A3238 File Offset: 0x000A1438
	// (set) Token: 0x06000144 RID: 324 RVA: 0x00002A01 File Offset: 0x00000C01
	public unsafe Vector2 bezierPt2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt2);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt2)) = value;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000145 RID: 325 RVA: 0x000A3260 File Offset: 0x000A1460
	// (set) Token: 0x06000146 RID: 326 RVA: 0x00002A1C File Offset: 0x00000C1C
	public unsafe Vector2 bezierPt3
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt3);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt3)) = value;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000147 RID: 327 RVA: 0x000A3288 File Offset: 0x000A1488
	// (set) Token: 0x06000148 RID: 328 RVA: 0x00002A37 File Offset: 0x00000C37
	public unsafe Vector2 bezierPt4
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt4);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.NativeFieldInfoPtr_bezierPt4)) = value;
		}
	}

	// Token: 0x040000C2 RID: 194
	private static readonly IntPtr NativeFieldInfoPtr_finishAutoCompleteEvents;

	// Token: 0x040000C3 RID: 195
	private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

	// Token: 0x040000C4 RID: 196
	private static readonly IntPtr NativeFieldInfoPtr_refuseButton;

	// Token: 0x040000C5 RID: 197
	private static readonly IntPtr NativeFieldInfoPtr_finalPosition;

	// Token: 0x040000C6 RID: 198
	private static readonly IntPtr NativeFieldInfoPtr_bezierPt1;

	// Token: 0x040000C7 RID: 199
	private static readonly IntPtr NativeFieldInfoPtr_bezierPt2;

	// Token: 0x040000C8 RID: 200
	private static readonly IntPtr NativeFieldInfoPtr_bezierPt3;

	// Token: 0x040000C9 RID: 201
	private static readonly IntPtr NativeFieldInfoPtr_bezierPt4;

	// Token: 0x040000CA RID: 202
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

	// Token: 0x040000CB RID: 203
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Action_0;

	// Token: 0x040000CC RID: 204
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

	// Token: 0x040000CD RID: 205
	private static readonly IntPtr NativeMethodInfoPtr_Confirm_Private_Void_0;

	// Token: 0x040000CE RID: 206
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x040000CF RID: 207
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000D0 RID: 208
	private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Transform_Single_Vector3_PDM_0;

	// Token: 0x040000D1 RID: 209
	private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_byref___c__DisplayClass11_1_PDM_0;

	// Token: 0x040000D2 RID: 210
	private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_byref___c__DisplayClass11_1_0;

	// Token: 0x0200046C RID: 1132
	[ObfuscatedName("DaySceneSleepAndSavePannel+<>c__DisplayClass11_0")]
	public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
	{
		// Token: 0x06007C21 RID: 31777 RVA: 0x00239E68 File Offset: 0x00238068
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass11_0()
		{
			Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "<>c__DisplayClass11_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr);
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, "player");
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_rotateCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, "rotateCorotine");
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_canOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, "canOpen");
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, 100663441);
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr__Confirm_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, 100663442);
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, 100663443);
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Func_1_Vector3_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, 100663444);
			DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr__Confirm_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, 100663445);
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x00239F48 File Offset: 0x00238148
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x00239F84 File Offset: 0x00238184
		[CallerCount(0)]
		public unsafe Vector3 _Confirm_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr__Confirm_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x00239FC0 File Offset: 0x002381C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17579, XrefRangeEnd = 17580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Method_Internal_Single_Single_PDM_0(float input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref input;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Single_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x0023A00C File Offset: 0x0023820C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17580, XrefRangeEnd = 17587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Internal_IEnumerator_Transform_Func_1_Vector3_Single_Single_PDM_0(Transform source, Func<Vector3> targetPosition, float launchHeight, float launchTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Func_1_Vector3_Single_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0023A08C File Offset: 0x0023828C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17587, XrefRangeEnd = 17596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Confirm_b__6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeMethodInfoPtr__Confirm_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x00042CBE File Offset: 0x00040EBE
		public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x06007C28 RID: 31784 RVA: 0x0023A0C0 File Offset: 0x002382C0
		// (set) Token: 0x06007C29 RID: 31785 RVA: 0x00042CC7 File Offset: 0x00040EC7
		public unsafe DaySceneSleepAndSavePannel __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSleepAndSavePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x06007C2A RID: 31786 RVA: 0x0023A0F0 File Offset: 0x002382F0
		// (set) Token: 0x06007C2B RID: 31787 RVA: 0x00042CE6 File Offset: 0x00040EE6
		public unsafe DayScenePlayerInputGenerator player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06007C2C RID: 31788 RVA: 0x0023A120 File Offset: 0x00238320
		// (set) Token: 0x06007C2D RID: 31789 RVA: 0x00042D05 File Offset: 0x00040F05
		public unsafe Coroutine rotateCorotine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_rotateCorotine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_rotateCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06007C2E RID: 31790 RVA: 0x0023A150 File Offset: 0x00238350
		// (set) Token: 0x06007C2F RID: 31791 RVA: 0x00042D24 File Offset: 0x00040F24
		public unsafe bool canOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_canOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.NativeFieldInfoPtr_canOpen)) = value;
			}
		}

		// Token: 0x040051AE RID: 20910
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040051AF RID: 20911
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040051B0 RID: 20912
		private static readonly IntPtr NativeFieldInfoPtr_rotateCorotine;

		// Token: 0x040051B1 RID: 20913
		private static readonly IntPtr NativeFieldInfoPtr_canOpen;

		// Token: 0x040051B2 RID: 20914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051B3 RID: 20915
		private static readonly IntPtr NativeMethodInfoPtr__Confirm_b__0_Internal_Vector3_0;

		// Token: 0x040051B4 RID: 20916
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Single_Single_PDM_0;

		// Token: 0x040051B5 RID: 20917
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Func_1_Vector3_Single_Single_PDM_0;

		// Token: 0x040051B6 RID: 20918
		private static readonly IntPtr NativeMethodInfoPtr__Confirm_b__6_Internal_Void_0;

		// Token: 0x02000FA4 RID: 4004
		[ObfuscatedName("DaySceneSleepAndSavePannel+<>c__DisplayClass11_0+<<Confirm>g__Jump|3>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique : Il2CppSystem.Object
		{
			// Token: 0x06011453 RID: 70739 RVA: 0x003F9C7C File Offset: 0x003F7E7C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique()
			{
				Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>.NativeClassPtr, "<<Confirm>g__Jump|3>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr);
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "<>1__state");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "<>2__current");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "targetPosition");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "launchHeight");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "source");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "<>4__this");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_launchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "launchTime");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "<>8__1");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr__progress_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "<progress>5__2");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr__hasTurned_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, "<hasTurned>5__3");
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, 100663446);
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, 100663447);
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, 100663448);
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, 100663449);
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, 100663450);
				DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr, 100663451);
			}

			// Token: 0x06011454 RID: 70740 RVA: 0x003F9DE8 File Offset: 0x003F7FE8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3956, XrefRangeEnd = 3957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011455 RID: 70741 RVA: 0x003F9E30 File Offset: 0x003F8030
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011456 RID: 70742 RVA: 0x003F9E64 File Offset: 0x003F8064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17547, XrefRangeEnd = 17573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170059C8 RID: 22984
			// (get) Token: 0x06011457 RID: 70743 RVA: 0x003F9EA0 File Offset: 0x003F80A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06011458 RID: 70744 RVA: 0x003F9EE0 File Offset: 0x003F80E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17573, XrefRangeEnd = 17579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170059C9 RID: 22985
			// (get) Token: 0x06011459 RID: 70745 RVA: 0x003F9F14 File Offset: 0x003F8114
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601145A RID: 70746 RVA: 0x000963A7 File Offset: 0x000945A7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170059BE RID: 22974
			// (get) Token: 0x0601145B RID: 70747 RVA: 0x003F9F54 File Offset: 0x003F8154
			// (set) Token: 0x0601145C RID: 70748 RVA: 0x000963B0 File Offset: 0x000945B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170059BF RID: 22975
			// (get) Token: 0x0601145D RID: 70749 RVA: 0x003F9F7C File Offset: 0x003F817C
			// (set) Token: 0x0601145E RID: 70750 RVA: 0x000963CB File Offset: 0x000945CB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059C0 RID: 22976
			// (get) Token: 0x0601145F RID: 70751 RVA: 0x003F9FAC File Offset: 0x003F81AC
			// (set) Token: 0x06011460 RID: 70752 RVA: 0x000963EA File Offset: 0x000945EA
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059C1 RID: 22977
			// (get) Token: 0x06011461 RID: 70753 RVA: 0x003F9FDC File Offset: 0x003F81DC
			// (set) Token: 0x06011462 RID: 70754 RVA: 0x00096409 File Offset: 0x00094609
			public unsafe float launchHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_launchHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_launchHeight)) = value;
				}
			}

			// Token: 0x170059C2 RID: 22978
			// (get) Token: 0x06011463 RID: 70755 RVA: 0x003FA004 File Offset: 0x003F8204
			// (set) Token: 0x06011464 RID: 70756 RVA: 0x00096424 File Offset: 0x00094624
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059C3 RID: 22979
			// (get) Token: 0x06011465 RID: 70757 RVA: 0x003FA034 File Offset: 0x003F8234
			// (set) Token: 0x06011466 RID: 70758 RVA: 0x00096443 File Offset: 0x00094643
			public unsafe DaySceneSleepAndSavePannel.__c__DisplayClass11_0 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSleepAndSavePannel.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059C4 RID: 22980
			// (get) Token: 0x06011467 RID: 70759 RVA: 0x003FA064 File Offset: 0x003F8264
			// (set) Token: 0x06011468 RID: 70760 RVA: 0x00096462 File Offset: 0x00094662
			public unsafe float launchTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_launchTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr_launchTime)) = value;
				}
			}

			// Token: 0x170059C5 RID: 22981
			// (get) Token: 0x06011469 RID: 70761 RVA: 0x003FA08C File Offset: 0x003F828C
			// (set) Token: 0x0601146A RID: 70762 RVA: 0x0009647D File Offset: 0x0009467D
			public DaySceneSleepAndSavePannel.__c__DisplayClass11_1 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___8__1);
					return new DaySceneSleepAndSavePannel.__c__DisplayClass11_1(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr___8__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170059C6 RID: 22982
			// (get) Token: 0x0601146B RID: 70763 RVA: 0x003FA0BC File Offset: 0x003F82BC
			// (set) Token: 0x0601146C RID: 70764 RVA: 0x000964AB File Offset: 0x000946AB
			public unsafe float _progress_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr__progress_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr__progress_5__2)) = value;
				}
			}

			// Token: 0x170059C7 RID: 22983
			// (get) Token: 0x0601146D RID: 70765 RVA: 0x003FA0E4 File Offset: 0x003F82E4
			// (set) Token: 0x0601146E RID: 70766 RVA: 0x000964C6 File Offset: 0x000946C6
			public unsafe bool _hasTurned_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr__hasTurned_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1VetaSilaTrsoUnique.NativeFieldInfoPtr__hasTurned_5__3)) = value;
				}
			}

			// Token: 0x0400AE95 RID: 44693
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE96 RID: 44694
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE97 RID: 44695
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x0400AE98 RID: 44696
			private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

			// Token: 0x0400AE99 RID: 44697
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400AE9A RID: 44698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE9B RID: 44699
			private static readonly IntPtr NativeFieldInfoPtr_launchTime;

			// Token: 0x0400AE9C RID: 44700
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400AE9D RID: 44701
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__2;

			// Token: 0x0400AE9E RID: 44702
			private static readonly IntPtr NativeFieldInfoPtr__hasTurned_5__3;

			// Token: 0x0400AE9F RID: 44703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AEA0 RID: 44704
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AEA1 RID: 44705
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AEA2 RID: 44706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AEA3 RID: 44707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AEA4 RID: 44708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}

	// Token: 0x0200046D RID: 1133
	[ObfuscatedName("DaySceneSleepAndSavePannel+<>c__DisplayClass11_1")]
	public sealed class __c__DisplayClass11_1 : ValueType
	{
		// Token: 0x06007C30 RID: 31792 RVA: 0x0023A178 File Offset: 0x00238378
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass11_1()
		{
			Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "<>c__DisplayClass11_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr);
			DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr, "start");
			DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr, "targetPosition");
			DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr, "launchHeight");
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x00042D3F File Offset: 0x00040F3F
		public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x00042D48 File Offset: 0x00040F48
		public __c__DisplayClass11_1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.__c__DisplayClass11_1>.NativeClassPtr))
		{
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x06007C33 RID: 31795 RVA: 0x0023A1E0 File Offset: 0x002383E0
		// (set) Token: 0x06007C34 RID: 31796 RVA: 0x00042D5A File Offset: 0x00040F5A
		public unsafe Vector3 start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x06007C35 RID: 31797 RVA: 0x0023A208 File Offset: 0x00238408
		// (set) Token: 0x06007C36 RID: 31798 RVA: 0x00042D75 File Offset: 0x00040F75
		public unsafe Func<Vector3> targetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_targetPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x06007C37 RID: 31799 RVA: 0x0023A238 File Offset: 0x00238438
		// (set) Token: 0x06007C38 RID: 31800 RVA: 0x00042D94 File Offset: 0x00040F94
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.__c__DisplayClass11_1.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x040051B7 RID: 20919
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040051B8 RID: 20920
		private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

		// Token: 0x040051B9 RID: 20921
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;
	}

	// Token: 0x0200046E RID: 1134
	[ObfuscatedName("DaySceneSleepAndSavePannel+<<Confirm>g__OnRotation|11_1>d")]
	public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique : Il2CppSystem.Object
	{
		// Token: 0x06007C39 RID: 31801 RVA: 0x0023A260 File Offset: 0x00238460
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique()
		{
			Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneSleepAndSavePannel>.NativeClassPtr, "<<Confirm>g__OnRotation|11_1>d");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr);
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "<>1__state");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "<>2__current");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "source");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "speed");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "point");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr__src_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "<src>5__2");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr__spd_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, "<spd>5__3");
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, 100663452);
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, 100663453);
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, 100663454);
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, 100663455);
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, 100663456);
			DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr, 100663457);
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x0023A390 File Offset: 0x00238590
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x0023A3D8 File Offset: 0x002385D8
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x0023A40C File Offset: 0x0023860C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17596, XrefRangeEnd = 17607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x06007C3D RID: 31805 RVA: 0x0023A448 File Offset: 0x00238648
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x0023A488 File Offset: 0x00238688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17607, XrefRangeEnd = 17613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x06007C3F RID: 31807 RVA: 0x0023A4BC File Offset: 0x002386BC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x00042DAF File Offset: 0x00040FAF
		public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x0023A4FC File Offset: 0x002386FC
		// (set) Token: 0x06007C42 RID: 31810 RVA: 0x00042DB8 File Offset: 0x00040FB8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x06007C43 RID: 31811 RVA: 0x0023A524 File Offset: 0x00238724
		// (set) Token: 0x06007C44 RID: 31812 RVA: 0x00042DD3 File Offset: 0x00040FD3
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x06007C45 RID: 31813 RVA: 0x0023A554 File Offset: 0x00238754
		// (set) Token: 0x06007C46 RID: 31814 RVA: 0x00042DF2 File Offset: 0x00040FF2
		public unsafe Transform source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x06007C47 RID: 31815 RVA: 0x0023A584 File Offset: 0x00238784
		// (set) Token: 0x06007C48 RID: 31816 RVA: 0x00042E11 File Offset: 0x00041011
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x06007C49 RID: 31817 RVA: 0x0023A5AC File Offset: 0x002387AC
		// (set) Token: 0x06007C4A RID: 31818 RVA: 0x00042E2C File Offset: 0x0004102C
		public unsafe Vector3 point
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_point);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr_point)) = value;
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x06007C4B RID: 31819 RVA: 0x0023A5D4 File Offset: 0x002387D4
		// (set) Token: 0x06007C4C RID: 31820 RVA: 0x00042E47 File Offset: 0x00041047
		public unsafe Transform _src_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr__src_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr__src_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x06007C4D RID: 31821 RVA: 0x0023A604 File Offset: 0x00238804
		// (set) Token: 0x06007C4E RID: 31822 RVA: 0x00042E66 File Offset: 0x00041066
		public unsafe float _spd_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr__spd_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrsoSispVepoTrSiUnique.NativeFieldInfoPtr__spd_5__3)) = value;
			}
		}

		// Token: 0x040051BA RID: 20922
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040051BB RID: 20923
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040051BC RID: 20924
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040051BD RID: 20925
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040051BE RID: 20926
		private static readonly IntPtr NativeFieldInfoPtr_point;

		// Token: 0x040051BF RID: 20927
		private static readonly IntPtr NativeFieldInfoPtr__src_5__2;

		// Token: 0x040051C0 RID: 20928
		private static readonly IntPtr NativeFieldInfoPtr__spd_5__3;

		// Token: 0x040051C1 RID: 20929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040051C2 RID: 20930
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040051C3 RID: 20931
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040051C4 RID: 20932
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040051C5 RID: 20933
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040051C6 RID: 20934
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
