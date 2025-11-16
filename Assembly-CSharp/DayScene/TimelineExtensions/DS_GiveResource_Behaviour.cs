using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000146 RID: 326
	public class DS_GiveResource_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002676 RID: 9846 RVA: 0x0011F5BC File Offset: 0x0011D7BC
		// Note: this type is marked as 'beforefieldinit'.
		static DS_GiveResource_Behaviour()
		{
			Il2CppClassPointerStore<DS_GiveResource_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_GiveResource_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_GiveResource_Behaviour>.NativeClassPtr);
			DS_GiveResource_Behaviour.NativeFieldInfoPtr_resourceCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_GiveResource_Behaviour>.NativeClassPtr, "resourceCode");
			DS_GiveResource_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_GiveResource_Behaviour>.NativeClassPtr, 100670197);
			DS_GiveResource_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_GiveResource_Behaviour>.NativeClassPtr, 100670198);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0011F628 File Offset: 0x0011D828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90273, XrefRangeEnd = 90278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_GiveResource_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x0011F664 File Offset: 0x0011D864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_GiveResource_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_GiveResource_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_GiveResource_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x00016ADB File Offset: 0x00014CDB
		public DS_GiveResource_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0011F6A0 File Offset: 0x0011D8A0
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x00016AE4 File Offset: 0x00014CE4
		public unsafe int resourceCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_GiveResource_Behaviour.NativeFieldInfoPtr_resourceCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_GiveResource_Behaviour.NativeFieldInfoPtr_resourceCode)) = value;
			}
		}

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeFieldInfoPtr_resourceCode;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
