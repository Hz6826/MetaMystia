using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200043C RID: 1084
	public class COM_DelayForSeconds_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x0600793F RID: 31039 RVA: 0x00230CB4 File Offset: 0x0022EEB4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_DelayForSeconds_Behaviour()
		{
			Il2CppClassPointerStore<COM_DelayForSeconds_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_DelayForSeconds_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_DelayForSeconds_Behaviour>.NativeClassPtr);
			COM_DelayForSeconds_Behaviour.NativeFieldInfoPtr_delayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_DelayForSeconds_Behaviour>.NativeClassPtr, "delayDuration");
			COM_DelayForSeconds_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_DelayForSeconds_Behaviour>.NativeClassPtr, 100687713);
			COM_DelayForSeconds_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_DelayForSeconds_Behaviour>.NativeClassPtr, 100687714);
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x00230D20 File Offset: 0x0022EF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294036, XrefRangeEnd = 294047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_DelayForSeconds_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x00230D5C File Offset: 0x0022EF5C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_DelayForSeconds_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_DelayForSeconds_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_DelayForSeconds_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x000418BE File Offset: 0x0003FABE
		public COM_DelayForSeconds_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06007943 RID: 31043 RVA: 0x00230D98 File Offset: 0x0022EF98
		// (set) Token: 0x06007944 RID: 31044 RVA: 0x000418C7 File Offset: 0x0003FAC7
		public unsafe float delayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_DelayForSeconds_Behaviour.NativeFieldInfoPtr_delayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_DelayForSeconds_Behaviour.NativeFieldInfoPtr_delayDuration)) = value;
			}
		}

		// Token: 0x04004FD6 RID: 20438
		private static readonly IntPtr NativeFieldInfoPtr_delayDuration;

		// Token: 0x04004FD7 RID: 20439
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FD8 RID: 20440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
