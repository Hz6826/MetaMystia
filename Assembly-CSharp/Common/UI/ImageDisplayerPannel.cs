using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000381 RID: 897
	public class ImageDisplayerPannel : UIPanel
	{
		// Token: 0x06006A5F RID: 27231 RVA: 0x0020170C File Offset: 0x001FF90C
		// Note: this type is marked as 'beforefieldinit'.
		static ImageDisplayerPannel()
		{
			Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ImageDisplayerPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr);
			ImageDisplayerPannel.NativeFieldInfoPtr_MOVESPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "MOVESPEED");
			ImageDisplayerPannel.NativeFieldInfoPtr_SNAPDURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "SNAPDURATION");
			ImageDisplayerPannel.NativeFieldInfoPtr_movablePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "movablePannel");
			ImageDisplayerPannel.NativeFieldInfoPtr_navigationRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "navigationRangeMin");
			ImageDisplayerPannel.NativeFieldInfoPtr_areaHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "areaHeight");
			ImageDisplayerPannel.NativeFieldInfoPtr_m_ActiveCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "m_ActiveCoroutine");
			ImageDisplayerPannel.NativeFieldInfoPtr_forceAlignTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "forceAlignTop");
			ImageDisplayerPannel.NativeFieldInfoPtr_progressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "progressIndicator");
			ImageDisplayerPannel.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "targetPosition");
			ImageDisplayerPannel.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "velocity");
			ImageDisplayerPannel.NativeFieldInfoPtr_currentNavigationMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "currentNavigationMin");
			ImageDisplayerPannel.NativeFieldInfoPtr_currentNavigationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "currentNavigationMax");
			ImageDisplayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685324);
			ImageDisplayerPannel.NativeMethodInfoPtr_ScrollCallback_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685325);
			ImageDisplayerPannel.NativeMethodInfoPtr_Scroll_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685326);
			ImageDisplayerPannel.NativeMethodInfoPtr_ApplyOffset_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685327);
			ImageDisplayerPannel.NativeMethodInfoPtr_UpdatePosition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685328);
			ImageDisplayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685329);
			ImageDisplayerPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685330);
			ImageDisplayerPannel.NativeMethodInfoPtr_SetProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685331);
			ImageDisplayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685332);
			ImageDisplayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, 100685333);
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x002018F4 File Offset: 0x001FFAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270736, XrefRangeEnd = 270756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageDisplayerPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00201930 File Offset: 0x001FFB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270756, XrefRangeEnd = 270761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollCallback(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel.NativeMethodInfoPtr_ScrollCallback_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00201978 File Offset: 0x001FFB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270762, RefRangeEnd = 270763, XrefRangeStart = 270761, XrefRangeEnd = 270762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Scroll(MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel.NativeMethodInfoPtr_Scroll_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x002019B8 File Offset: 0x001FFBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270763, XrefRangeEnd = 270764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOffset(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel.NativeMethodInfoPtr_ApplyOffset_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x002019F8 File Offset: 0x001FFBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270764, XrefRangeEnd = 270769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel.NativeMethodInfoPtr_UpdatePosition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x00201A38 File Offset: 0x001FFC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270769, XrefRangeEnd = 270784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageDisplayerPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x00201A74 File Offset: 0x001FFC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270784, XrefRangeEnd = 270786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageDisplayerPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00201AB0 File Offset: 0x001FFCB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270794, RefRangeEnd = 270796, XrefRangeStart = 270786, XrefRangeEnd = 270794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel.NativeMethodInfoPtr_SetProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00201AE4 File Offset: 0x001FFCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270796, XrefRangeEnd = 270800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageDisplayerPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00201B20 File Offset: 0x001FFD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270800, XrefRangeEnd = 270801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageDisplayerPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x000398A8 File Offset: 0x00037AA8
		public ImageDisplayerPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x06006A6B RID: 27243 RVA: 0x00201B5C File Offset: 0x001FFD5C
		// (set) Token: 0x06006A6C RID: 27244 RVA: 0x000398B1 File Offset: 0x00037AB1
		public unsafe static float MOVESPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImageDisplayerPannel.NativeFieldInfoPtr_MOVESPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageDisplayerPannel.NativeFieldInfoPtr_MOVESPEED, (void*)(&value));
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x06006A6D RID: 27245 RVA: 0x00201B78 File Offset: 0x001FFD78
		// (set) Token: 0x06006A6E RID: 27246 RVA: 0x000398BF File Offset: 0x00037ABF
		public unsafe static float SNAPDURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImageDisplayerPannel.NativeFieldInfoPtr_SNAPDURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageDisplayerPannel.NativeFieldInfoPtr_SNAPDURATION, (void*)(&value));
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x06006A6F RID: 27247 RVA: 0x00201B94 File Offset: 0x001FFD94
		// (set) Token: 0x06006A70 RID: 27248 RVA: 0x000398CD File Offset: 0x00037ACD
		public unsafe RectTransform movablePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_movablePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_movablePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x06006A71 RID: 27249 RVA: 0x00201BC4 File Offset: 0x001FFDC4
		// (set) Token: 0x06006A72 RID: 27250 RVA: 0x000398EC File Offset: 0x00037AEC
		public unsafe Vector2 navigationRangeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_navigationRangeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_navigationRangeMin)) = value;
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x06006A73 RID: 27251 RVA: 0x00201BEC File Offset: 0x001FFDEC
		// (set) Token: 0x06006A74 RID: 27252 RVA: 0x00039907 File Offset: 0x00037B07
		public unsafe float areaHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_areaHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_areaHeight)) = value;
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x00201C14 File Offset: 0x001FFE14
		// (set) Token: 0x06006A76 RID: 27254 RVA: 0x00039922 File Offset: 0x00037B22
		public unsafe Coroutine m_ActiveCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_m_ActiveCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_m_ActiveCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x06006A77 RID: 27255 RVA: 0x00201C44 File Offset: 0x001FFE44
		// (set) Token: 0x06006A78 RID: 27256 RVA: 0x00039941 File Offset: 0x00037B41
		public unsafe bool forceAlignTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_forceAlignTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_forceAlignTop)) = value;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x06006A79 RID: 27257 RVA: 0x00201C6C File Offset: 0x001FFE6C
		// (set) Token: 0x06006A7A RID: 27258 RVA: 0x0003995C File Offset: 0x00037B5C
		public unsafe AdpProgressIndicatorComponent progressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_progressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_progressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x06006A7B RID: 27259 RVA: 0x00201C9C File Offset: 0x001FFE9C
		// (set) Token: 0x06006A7C RID: 27260 RVA: 0x0003997B File Offset: 0x00037B7B
		public unsafe Vector2 targetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_targetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_targetPosition)) = value;
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x00201CC4 File Offset: 0x001FFEC4
		// (set) Token: 0x06006A7E RID: 27262 RVA: 0x00039996 File Offset: 0x00037B96
		public unsafe Vector2 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x00201CEC File Offset: 0x001FFEEC
		// (set) Token: 0x06006A80 RID: 27264 RVA: 0x000399B1 File Offset: 0x00037BB1
		public unsafe Vector2 currentNavigationMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_currentNavigationMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_currentNavigationMin)) = value;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x00201D14 File Offset: 0x001FFF14
		// (set) Token: 0x06006A82 RID: 27266 RVA: 0x000399CC File Offset: 0x00037BCC
		public unsafe Vector2 currentNavigationMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_currentNavigationMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel.NativeFieldInfoPtr_currentNavigationMax)) = value;
			}
		}

		// Token: 0x04004687 RID: 18055
		private static readonly IntPtr NativeFieldInfoPtr_MOVESPEED;

		// Token: 0x04004688 RID: 18056
		private static readonly IntPtr NativeFieldInfoPtr_SNAPDURATION;

		// Token: 0x04004689 RID: 18057
		private static readonly IntPtr NativeFieldInfoPtr_movablePannel;

		// Token: 0x0400468A RID: 18058
		private static readonly IntPtr NativeFieldInfoPtr_navigationRangeMin;

		// Token: 0x0400468B RID: 18059
		private static readonly IntPtr NativeFieldInfoPtr_areaHeight;

		// Token: 0x0400468C RID: 18060
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCoroutine;

		// Token: 0x0400468D RID: 18061
		private static readonly IntPtr NativeFieldInfoPtr_forceAlignTop;

		// Token: 0x0400468E RID: 18062
		private static readonly IntPtr NativeFieldInfoPtr_progressIndicator;

		// Token: 0x0400468F RID: 18063
		private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

		// Token: 0x04004690 RID: 18064
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04004691 RID: 18065
		private static readonly IntPtr NativeFieldInfoPtr_currentNavigationMin;

		// Token: 0x04004692 RID: 18066
		private static readonly IntPtr NativeFieldInfoPtr_currentNavigationMax;

		// Token: 0x04004693 RID: 18067
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004694 RID: 18068
		private static readonly IntPtr NativeMethodInfoPtr_ScrollCallback_Private_Void_CallbackContext_0;

		// Token: 0x04004695 RID: 18069
		private static readonly IntPtr NativeMethodInfoPtr_Scroll_Private_Void_MoveDirection_0;

		// Token: 0x04004696 RID: 18070
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOffset_Private_Void_Vector2_0;

		// Token: 0x04004697 RID: 18071
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Private_IEnumerator_0;

		// Token: 0x04004698 RID: 18072
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004699 RID: 18073
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400469A RID: 18074
		private static readonly IntPtr NativeMethodInfoPtr_SetProgress_Private_Void_0;

		// Token: 0x0400469B RID: 18075
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400469C RID: 18076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E96 RID: 3734
		[ObfuscatedName("Common.UI.ImageDisplayerPannel+<UpdatePosition>d__16")]
		public sealed class _UpdatePosition_d__16 : Il2CppSystem.Object
		{
			// Token: 0x060108AA RID: 67754 RVA: 0x003D595C File Offset: 0x003D3B5C
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdatePosition_d__16()
			{
				Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageDisplayerPannel>.NativeClassPtr, "<UpdatePosition>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr);
				ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, "<>1__state");
				ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, "<>2__current");
				ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, "<>4__this");
				ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr__waitForSecRealtimeFrame_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, "<waitForSecRealtimeFrame>5__2");
				ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, 100685334);
				ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, 100685335);
				ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, 100685336);
				ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, 100685337);
				ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, 100685338);
				ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr, 100685339);
			}

			// Token: 0x060108AB RID: 67755 RVA: 0x003D5A50 File Offset: 0x003D3C50
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdatePosition_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageDisplayerPannel._UpdatePosition_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108AC RID: 67756 RVA: 0x003D5A98 File Offset: 0x003D3C98
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108AD RID: 67757 RVA: 0x003D5ACC File Offset: 0x003D3CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270703, XrefRangeEnd = 270730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700565B RID: 22107
			// (get) Token: 0x060108AE RID: 67758 RVA: 0x003D5B08 File Offset: 0x003D3D08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060108AF RID: 67759 RVA: 0x003D5B48 File Offset: 0x003D3D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270730, XrefRangeEnd = 270736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700565C RID: 22108
			// (get) Token: 0x060108B0 RID: 67760 RVA: 0x003D5B7C File Offset: 0x003D3D7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageDisplayerPannel._UpdatePosition_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060108B1 RID: 67761 RVA: 0x000906DE File Offset: 0x0008E8DE
			public _UpdatePosition_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005657 RID: 22103
			// (get) Token: 0x060108B2 RID: 67762 RVA: 0x003D5BBC File Offset: 0x003D3DBC
			// (set) Token: 0x060108B3 RID: 67763 RVA: 0x000906E7 File Offset: 0x0008E8E7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005658 RID: 22104
			// (get) Token: 0x060108B4 RID: 67764 RVA: 0x003D5BE4 File Offset: 0x003D3DE4
			// (set) Token: 0x060108B5 RID: 67765 RVA: 0x00090702 File Offset: 0x0008E902
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005659 RID: 22105
			// (get) Token: 0x060108B6 RID: 67766 RVA: 0x003D5C14 File Offset: 0x003D3E14
			// (set) Token: 0x060108B7 RID: 67767 RVA: 0x00090721 File Offset: 0x0008E921
			public unsafe ImageDisplayerPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageDisplayerPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700565A RID: 22106
			// (get) Token: 0x060108B8 RID: 67768 RVA: 0x003D5C44 File Offset: 0x003D3E44
			// (set) Token: 0x060108B9 RID: 67769 RVA: 0x00090740 File Offset: 0x0008E940
			public unsafe WaitForSecondsRealtime _waitForSecRealtimeFrame_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr__waitForSecRealtimeFrame_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageDisplayerPannel._UpdatePosition_d__16.NativeFieldInfoPtr__waitForSecRealtimeFrame_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A76B RID: 42859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A76C RID: 42860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A76D RID: 42861
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A76E RID: 42862
			private static readonly IntPtr NativeFieldInfoPtr__waitForSecRealtimeFrame_5__2;

			// Token: 0x0400A76F RID: 42863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A770 RID: 42864
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A771 RID: 42865
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A772 RID: 42866
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A773 RID: 42867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A774 RID: 42868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
