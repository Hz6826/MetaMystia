using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000147 RID: 327
	public class DS_SetSelectedMapLabel_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600267C RID: 9852 RVA: 0x0011F6C8 File Offset: 0x0011D8C8
		// Note: this type is marked as 'beforefieldinit'.
		static DS_SetSelectedMapLabel_Behaviour()
		{
			Il2CppClassPointerStore<DS_SetSelectedMapLabel_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_SetSelectedMapLabel_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_SetSelectedMapLabel_Behaviour>.NativeClassPtr);
			DS_SetSelectedMapLabel_Behaviour.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_SetSelectedMapLabel_Behaviour>.NativeClassPtr, "mapLabel");
			DS_SetSelectedMapLabel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSelectedMapLabel_Behaviour>.NativeClassPtr, 100670199);
			DS_SetSelectedMapLabel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSelectedMapLabel_Behaviour>.NativeClassPtr, 100670200);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x0011F734 File Offset: 0x0011D934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90278, XrefRangeEnd = 90283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_SetSelectedMapLabel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x0011F770 File Offset: 0x0011D970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_SetSelectedMapLabel_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_SetSelectedMapLabel_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_SetSelectedMapLabel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00016AFF File Offset: 0x00014CFF
		public DS_SetSelectedMapLabel_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0011F7AC File Offset: 0x0011D9AC
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x00016B08 File Offset: 0x00014D08
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSelectedMapLabel_Behaviour.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSelectedMapLabel_Behaviour.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
