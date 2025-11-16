using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E5 RID: 485
	public class COM_LogicBranch_Goto_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C6E RID: 15470 RVA: 0x0016BE74 File Offset: 0x0016A074
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_Goto_Behaviour()
		{
			Il2CppClassPointerStore<COM_LogicBranch_Goto_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "COM_LogicBranch_Goto_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_Goto_Behaviour>.NativeClassPtr);
			COM_LogicBranch_Goto_Behaviour.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_Goto_Behaviour>.NativeClassPtr, "ticks");
			COM_LogicBranch_Goto_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_Goto_Behaviour>.NativeClassPtr, 100674494);
			COM_LogicBranch_Goto_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_Goto_Behaviour>.NativeClassPtr, 100674495);
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x0016BEE0 File Offset: 0x0016A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136815, XrefRangeEnd = 136820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_Goto_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x0016BF1C File Offset: 0x0016A11C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_Goto_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_Goto_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_Goto_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00021E81 File Offset: 0x00020081
		public COM_LogicBranch_Goto_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x0016BF58 File Offset: 0x0016A158
		// (set) Token: 0x06003C73 RID: 15475 RVA: 0x00021E8A File Offset: 0x0002008A
		public unsafe int ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_Goto_Behaviour.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_Goto_Behaviour.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
